using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bounced_Check_Manager
{
    namespace Bounced_Check_Manager_Data_Layer
    {
        class LetterDAO
        {
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

                // Generate letters

                throw new NotImplementedException();
                return list;
            }

        }
    }
}
