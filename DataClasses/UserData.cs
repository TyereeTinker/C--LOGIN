using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LOGIN.DataClasses
{
    [FirestoreData]   
    internal class UserData
    {
        [FirestoreProperty]
        public string fullName {  get; set; }

        [FirestoreProperty]
        public string userName { get; set; }

        [FirestoreProperty]
        public string password { get; set; }    
    }
}
