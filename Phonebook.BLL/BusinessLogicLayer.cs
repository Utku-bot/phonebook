using CsvHelper;
using Phonebook.Entities;
using System.ComponentModel;
using System.Globalization;
using System.Xml.Linq;

namespace Phonebook.BLL
{
    public class BusinessLogicLayer
    {
        Phonebook.Core.DatabaseLogicLayer DLL;
        const string XLM_LOCATION = @"e:\PhonebookDB\xmlData.xml";
        const string CSV_LOCATION = @"e:\PhonebookDB\csvData.csv";
        const string JSON_LOCATION = @"e:\PhonebookDB\jsonData.json";




        public BusinessLogicLayer()
        {
            DLL = new Phonebook.Core.DatabaseLogicLayer();
        }

        public int UserControl(string UserName,string Password)
        {
            int result = 0;
            if (!string.IsNullOrEmpty(UserName)&& !string.IsNullOrEmpty(Password)) { 
            
            User user = new User();
            user.UserName = UserName;
            user.Password = Password;
            result = DLL.UserAuthentication(user);
            
            
            } else
            {
                result = -100;
            }
            return result;
        }



        public int AddRecord(Guid ID, string Name, string Surname, string PhoneNumber1, string PhoneNumber2,
            string PhoneNumber3, string EmailAddress, string Webpage, string Description,string Address)
        {
            int result = 0;
            if (ID != Guid.Empty && !string.IsNullOrEmpty(Name)&& !string.IsNullOrEmpty(Surname)&& !string.IsNullOrEmpty(PhoneNumber1))
            {
                DirectoryRegistration directoryRegistration = new DirectoryRegistration();
                directoryRegistration.ID = ID;
                directoryRegistration.Name = Name;
                directoryRegistration.Surname = Surname;
                directoryRegistration.PhoneNumber1 = PhoneNumber1;
                directoryRegistration.PhoneNumber2 = PhoneNumber2;
                directoryRegistration.PhoneNumber3 = PhoneNumber3;
                directoryRegistration.EmailAddress = EmailAddress;
                directoryRegistration.Webpage = Webpage;
                directoryRegistration.Description = Description;
                directoryRegistration.Address = Address;

               result = DLL.AddRecord(directoryRegistration);
            }
            else
            {
                result = -100;
            }
            return result;



        }

        public int UpdateRecord(Guid ID, string Name, string Surname, string PhoneNumber1, string PhoneNumber2,
            string PhoneNumber3, string EmailAddress, string Webpage, string Description, string Address)
        {
            int result = 0;

            if (ID != Guid.Empty && !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Surname) && !string.IsNullOrEmpty(PhoneNumber1))
            {

                DirectoryRegistration directoryRegistration = new DirectoryRegistration();
                directoryRegistration.ID = ID;
                directoryRegistration.Name = Name;
                directoryRegistration.Surname = Surname;
                directoryRegistration.PhoneNumber1 = PhoneNumber1;
                directoryRegistration.PhoneNumber2 = PhoneNumber2;
                directoryRegistration.PhoneNumber3 = PhoneNumber3;
                directoryRegistration.EmailAddress = EmailAddress;
                directoryRegistration.Webpage = Webpage;
                directoryRegistration.Description = Description;
                directoryRegistration.Address = Address;
               result = DLL.UpdateRecord(directoryRegistration);

            }
            else
            {
                result = -100;
            }

                return result;
        }


        public int DeleteRecord(Guid ID)
        {


            return DLL.DeleteRecord(ID);



        }





        public List<DirectoryRegistration> GetRegistration()
        {
            return DLL.GetRegistrations();
        }




        public int GetXMLData()
        {
            int result = 0;
            try
            {
                List<DirectoryRegistration> directoryRegistrations = DLL.GetRegistrations();
                XDocument Doc = new XDocument(new XDeclaration("1.0.0.1", "UTF-8", "yes"), new XElement("RehberKayitlar", directoryRegistrations.Select(I => new XElement("Kayit", new XElement("ID", I.ID), new XElement("Name", I.Name), new XElement("Surname", I.Surname), new XElement("Phonenumber1", I.PhoneNumber1), new XElement("Phonenumber2", I.PhoneNumber2), new XElement("PhoneNumber3", I.PhoneNumber3), new XElement("EmailAddress", I.EmailAddress), new XElement("Address", I.Address), new XElement("Webpage", I.Webpage), new XElement("Description", I.Description)))));
                Doc.Save(XLM_LOCATION);
                result = 1;


            }
            catch (Exception)
            {

                result = 0;
            }
            return result;
        }



        public int GetCSVData()
        {
            int result = 0;
            try
            {
                List<DirectoryRegistration> directoryRegistrations = DLL.GetRegistrations();
                StreamWriter SW = new StreamWriter(CSV_LOCATION);
                CsvHelper.CsvWriter Write = new CsvHelper.CsvWriter(SW, CultureInfo.GetCultureInfo("tr_TR"));
                

                Write.WriteHeader<DirectoryRegistration>();
                Write.NextRecord();

                Write.WriteRecords(directoryRegistrations);
                
                SW.Flush();

                result = 1;


            }
            catch (Exception)
            {

                result = 0;
            }
            return result;
        }



        public int GetJsonData()
        {
            int result = 0;
            try
            {
                List<DirectoryRegistration> directoryRegistrations = DLL.GetRegistrations();
                string jsonText =  Newtonsoft.Json.JsonConvert.SerializeObject(directoryRegistrations);
                File.WriteAllText(JSON_LOCATION, jsonText);




                result = 1;


            }
            catch (Exception)
            {

                result = 0;
            }
            return result;
        }







    }
    
    }
