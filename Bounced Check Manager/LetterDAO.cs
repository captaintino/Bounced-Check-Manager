using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bounced_Check_Manager
{
    namespace Bounced_Check_Manager_Data_Layer
    {
        class LetterDAO
        {
            static List<String> lettersText = new List<string> { 
// LETTER ONE:
@"Date: {sendDate}

To: {checkAddress}

Dear : {accountName}


This is to inform you that your check dated {checkDate}, payable to {storeName}, in the amount of {checkAmnt}, has been returned to us due to insufficient funds.

We realize that such mishaps do occur and therefore are bringing this matter to your attention so that you will take the opportunity to correct this error and issue us a new check.

It is our policy to retain the old check until a new check is issued and cleared as we have unfortunately realized that there are some people who do not honor their debts. If a new check is not issued and the old check does not clear we will pursue legal action to the full extend of the law.

We are confident that you will resolve this matter and look forward to doing business with you again in the future.

Our thanks for your attention to this matter.

Very truly yours,


{storeManager}
", 
 // LETTER TWO:
@"Date: {sendDate}

To: {checkAddress}

Dear : {accountName}


This is a second letter to inform you that your check dated {checkDate}, payable to {storeName}, in the amount of ${checkAmnt}, has been returned to us due to insufficient funds.

Unless full payment of the check is received by cash together with ${fee} in bank fees, I will file a small claims court claim against you.
The claim will also request damages for the amount of the check, ${checkAmnt}, plus ${fee} damages assessed, for a total claim of ${totalAmnt} against you.
We realize that such mishaps do occur and therefore are bringing this matter to your attention through one more grace letter so that you will take the opportunity to correct this error and issue us a new check.

It is our policy to retain the old check until a new check is issued and cleared as we have unfortunately realized that there are some people who do not honor their debts. If a new check is not issued and the old check does not clear we will pursue legal action to the full extend of the law.

We are confident that you will resolve this matter and look forward to doing business with you again in the future.

Thank you for your attention to this matter.

{storeManager}

", 
 // LETTER THREE:
@"Send certified mail.
Date:{sendDate}

{accountName}

{checkAddress}

Dear {accountName}:
The check you wrote for {checkAmnt}, dated {checkDate}, which was made payable to {storeName}, was returned by {bankName} because the account was either closed OR the account had insufficient funds.

Unless full payment of the check is received by cash within 30 days after the date this demand letter was mailed, together with {fee} in bank fees, and {checkAmnt}, the cost of mailing this demand letter by certified mail, I will file a small claims court claim against you.

The claim will also request damages for the amount of the check, {checkAmnt}, plus {fee} damages assessed, for a total claim of {totalAmnt} against you.

You may wish to contact a lawyer to discuss your legal rights and responsibilities.
Please send your payment to:

{storeManager}
{storeAddress}

X_____________________________
" };
            // Get list of all of the Letters in the database
            public static List<Letter> LoadAll()
            {
                List<Letter> list = new List<Letter>();
                using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
                {
                    var query = from a in database.Letters
                                select a;
                    try
                    {
                        foreach (var a in query)
                        {
                            list.Add(a);
                        }
                    }
                    catch (Exception e)
                    {
                        return new List<Letter>();
                    }
                }
                return list;
            }

            // Create Letter <letter>
            public static bool create(Letter letter)
            {
                using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
                {
                    database.Letters.InsertOnSubmit(letter);
                    try
                    {
                        database.SubmitChanges();
                        return true;
                    }
                    catch (Exception e)
                    {
                        return false;
                    }
                }
            }

            // Update Letter <store>
            public static bool update(Letter letter)
            {
                using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
                {
                    var query = from a in database.Letters
                                where (a.LetterID == letter.LetterID)
                                select a;
                    foreach (var a in query)
                    {
                        a.CheckID = letter.CheckID;
                        a.LetterDateReceived = letter.LetterDateReceived;
                        a.LetterDateSent = letter.LetterDateSent;
                        a.LetterNum = letter.LetterNum;
                    }
                    try
                    {
                        database.SubmitChanges();
                        return true;
                    }
                    catch (Exception e)
                    {
                        return false;
                    }
                }
            }

            // Find first letter having id of of <letterID>
            public static Letter find(int letterID)
            {
                using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
                {
                    var query = from a in database.Letters
                                where (a.LetterID == letterID)
                                select a;
                    try
                    {
                        foreach (var a in query)
                        {
                            return a;
                        }
                    }
                    catch (Exception e)
                    {
                        return null;
                    }
                    return null;
                }
            }

            // Delete Letter <letter> from database
            public static bool delete(Letter letter)
            {
                using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
                {
                    var query = from a in database.Letters
                                where (a.LetterID == letter.LetterID)
                                select a;
                    // It seems to me that a single account renders the foreach unnecessary. However, I can't
                    // find another way to get the variable 'a' from 'query'.
                    foreach (var a in query)
                    {
                        database.Letters.DeleteOnSubmit(a);
                        try
                        {
                            database.SubmitChanges();
                            return true;
                        }
                        catch (Exception e)
                        {
                            return false;
                        }
                    }
                    return false;
                }
            }

            public static List<Tuple<Letter, String>> generateLetters()
            {
                List<Tuple<Letter, String>> list = new List<Tuple<Letter, String>>();
                // Get the checks that need letters
                try
                {
                    SqlConnection sqlConnection1 = new SqlConnection(Globals.connectionString);
                    SqlCommand cmd = new SqlCommand();
                    SqlDataReader reader;

                    cmd.CommandText = @"exec TeamPenguin.dbo.ChecksNeedingLetters;";

                    cmd.Connection = sqlConnection1;
                    sqlConnection1.Open();
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int checkID = reader.GetInt32(0);
                            int letterNum = reader.GetInt32(1);
                            // Generate letters
                            Letter letter = new Letter();
                            letter.LetterDateSent = DateTime.Today;
                            letter.LetterNum = letterNum + 1;
                            letter.CheckID = checkID;
                            String letterText = writeLetter(checkID, lettersText[letterNum]);
                            list.Add(new Tuple<Letter, string>(letter, letterText));
                        }
                    }
                    reader.Close();
                    sqlConnection1.Close();
                    return list;
                }
                catch (Exception ex)
                {
                    return new List<Tuple<Letter, String>>();
                }
            }

            private static String writeLetter(int checkId, String letter)
            {
                Check check = CheckDAO.find(checkId);
                DateTime sendDate = DateTime.Today;
                String checkAddress = check.Account.AccountAddress;
                String accountName = check.Account.AccountFirstName + " " + check.Account.AccountLastName;
                DateTime checkDate = check.CheckDate;
                String storeName = check.Store.StoreName;
                double checkAmnt = check.CheckAmount;
                String bankName = check.Bank.BankName;
                double fee = Convert.ToDouble(check.Store.StoreServiceCharge);
                double totalAmnt = checkAmnt + fee;
                String storeManager = "HardCoded ---"; // TODO: Get an actual store manager value
                String storeAddress = check.Store.StoreAddress;
                return letter
                    .Replace("{sendDate}", sendDate.ToShortDateString())
                    .Replace("{accountName}", accountName)
                    .Replace("{checkDate}", checkDate.ToShortDateString())
                    .Replace("{checkAddress}", checkAddress)
                    .Replace("{storeName}", storeName)
                    .Replace("{checkAmnt}", checkAmnt.ToString("C"))
                    .Replace("{bankName}", bankName)
                    .Replace("{fee}", fee.ToString("C"))
                    .Replace("{totalAmnt}", totalAmnt.ToString("C"))
                    .Replace("{storeManager}", storeManager)
                    .Replace("{storeAddress}", storeAddress);
            }

        }
    }
}
