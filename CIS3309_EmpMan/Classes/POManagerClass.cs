//Nicholas Tran && Jimmy Pham
//CIS 3309
//Frank Friedman
//EmpMan Final Project
//4/30/2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CIS3309_EmpMan;

// To read and write files
using System.IO;
// To serialize a persistant object
using System.Runtime.Serialization.Formatters.Binary;

namespace CIS3309_EmpMan
{
    public static class POManagerClass
    {
        // This class manages the persistant object by reading from and writing to a file

        // Write the Person List to file as a serialized binary object
        public static bool writeToFile(ref PersonListClass plist, string fn)
        {
            Stream thisFileStream;
            BinaryFormatter serializer = new BinaryFormatter();

            if (plist.getPersonList().Count() > 0)
            {
                try
                {
                    thisFileStream = File.Create(fn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File open error: Person List not written", "POManager File Open");
                    MessageBox.Show(ex.ToString());
                    return false;
                }  // end Try

                try
                {
                    serializer.Serialize(thisFileStream, plist);
                    //MsgBox("File write: Person List was written")
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File write error: Person List not written", "POManager File Write");
                    MessageBox.Show(ex.ToString());
                    return false;
                }
                finally
                {
                    thisFileStream.Close();
                }  // end Try
            }
            else
                MessageBox.Show("No Person in List");
            // end if

            return true;  // The file write succeeded

        }  // end WriteToFile


        // Read the Person List from file as a serialized binary object
        public static bool readFromFile(out PersonListClass plist, string fn)
        {
            Stream TestFileStream;
            BinaryFormatter deserializer = new BinaryFormatter();

            if (File.Exists(fn))
            {
                try
                {
                    TestFileStream = File.OpenRead(fn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File open error: Open with new Person List", "POManager, File Open");
                    plist = new PersonListClass();
                    return false;
                }  // end Try

                try
                {
                    plist = (PersonListClass)deserializer.Deserialize(TestFileStream);
                    // pl = CType(deserializer.Deserialize(TestFileStream), PersonList);
                    // MsgBox("File open: Person loaded to List");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File read error: Open with new Person List", "POManager File Read");
                    plist = new PersonListClass();
                    return false;
                }
                finally
                {
                    TestFileStream.Close();
                }  // end Try
            }  // end then part of if
            else
            {
                MessageBox.Show("File does not exist: Open with new Person List", "PO Manager Exists ");
                plist = new PersonListClass();
            }  // end if

            return true;   // The file read succeeded

        }  // end readFromFile 

    }  // end POManager Class
}  // end namespace


