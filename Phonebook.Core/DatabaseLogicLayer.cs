
using Phonebook.Entities;
using System.Net.Mail;
using System.Net;
using System.Xml.Linq;

namespace Phonebook.Core
{

    public class DatabaseLogicLayer

    {
        const string FOLDER_LOCATION = @"e:\PhonebookDB\";
        const string FILE_LOCATION = @"e:\PhonebookDB\phoneBook.json";
        const string USER_FILE_LOCATION = @"e:\PhonebookDB\user.json";

        List<DirectoryRegistration> Registrations;
        public DatabaseLogicLayer()
        {

            Registrations = new List<DirectoryRegistration>();
            DataBaseControl();


        }

        private void DataBaseControl()
        {
            bool DirectoryControl = Directory.Exists(FOLDER_LOCATION);
            if (!DirectoryControl)
            {
                Directory.CreateDirectory(FOLDER_LOCATION);
                User userTemp = new User();
                userTemp.Id = Guid.NewGuid();
                userTemp.UserName = "Demo";
                userTemp.Password = "password";

                List<User> users = new List<User>();
                users.Add(userTemp);


                string jsonUserText = Newtonsoft.Json.JsonConvert.SerializeObject(users);
                File.WriteAllText(USER_FILE_LOCATION, jsonUserText);
            }

        }
        public int AddRecord(DirectoryRegistration directoryRegistration)
        {
            int result = 0;

            try
            {
                GetRegistrations();
                Registrations.Add(directoryRegistration);
                UpdateJsonDB();
                result = 1;
            }
            catch (Exception ex)
            {

                result = 0;
            }
            return result;
        }

        public int UpdateRecord(DirectoryRegistration directoryRegistration) { 
            int result = 0;

            try
            {
                GetRegistrations();
                int index = Registrations.FindIndex(i=>i.ID==directoryRegistration.ID);
                if (index > -1)
                {
                    Registrations[index].ID = directoryRegistration.ID;
                    Registrations[index].Name = directoryRegistration.Name;
                    Registrations[index].Surname = directoryRegistration.Surname;
                    Registrations[index].PhoneNumber1 = directoryRegistration.PhoneNumber1;
                    Registrations[index].PhoneNumber2 = directoryRegistration.PhoneNumber2;
                    Registrations[index].PhoneNumber3 = directoryRegistration.PhoneNumber3;
                    Registrations[index].EmailAddress = directoryRegistration.EmailAddress;
                    Registrations[index].Webpage = directoryRegistration.Webpage;
                    Registrations[index].Description = directoryRegistration.Description;
                    Registrations[index].Address = directoryRegistration.Address;
                }
                UpdateJsonDB();
                result = 1;

            }
            catch(Exception ex)
            {

            }





            return result;
        }


        public int DeleteRecord(Guid ID) { 
        
        int result =0;

            try
            {

                GetRegistrations();
              DirectoryRegistration delendaRegistration =  Registrations.Find(i=>i.ID==ID);
                if (delendaRegistration != null) { 
                
                    Registrations.Remove(delendaRegistration);
                
                }
                UpdateJsonDB();
                result = 1;

            }
            catch (Exception)
            {

                throw;
            }
        
        
        return result;
        
        }



        public List<DirectoryRegistration> GetRegistrations()
        {
            if (File.Exists(FILE_LOCATION))
            {

                string JsonDBText = File.ReadAllText(FILE_LOCATION);
                Registrations = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DirectoryRegistration>>(JsonDBText);
            }

            return Registrations;



        }

        public int UserAuthentication(User user)
        {
            int UserResult = 0;
            if (File.Exists(USER_FILE_LOCATION))
            {


                string JsonUserText = File.ReadAllText(USER_FILE_LOCATION);
                List<User> Users = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(JsonUserText);
                UserResult = Users.FindAll(i => i.UserName == user.UserName && i.Password == user.Password).ToList().Count();


            }



            return UserResult;
        }



        #region Supportive metods


        private void UpdateJsonDB()

        {
            if (Registrations != null && Registrations.Count > 0)
            {

                string JsonDB = Newtonsoft.Json.JsonConvert.SerializeObject(Registrations);
                File.WriteAllText(FILE_LOCATION, JsonDB);

            }


        }


        #endregion
    }
}
