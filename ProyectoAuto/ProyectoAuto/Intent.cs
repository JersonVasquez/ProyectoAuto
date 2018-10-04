using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ProyectoAuto
{
   

    public class Intent
    {
        public Page _startPage { get; set; }
        public Page _endPage { get; set; }
        public Dictionary<string, object> DataObject { get; set; }
        public Dictionary<string, string> DataString { get; set; }
 

        public Intent(Page startPage, Page endPage)
        {
            _startPage = startPage;
            _endPage = endPage;
            DataObject = new Dictionary<string, object>();
            DataString = new Dictionary<string, string>();
        }
        public void PutObject(string key, object obj)
        {
            if (DataObject.ContainsKey(key))
            {
                throw new ArgumentException("La llave si existe");
            }
            DataObject.Add(key, obj);
        }

        public void PutString(string key, string value)
        {
            if (DataString.ContainsKey(key))
            {
                throw new ArgumentException("La llave si existe");
            }
            DataString.Add(key, value);
        }

        public string GetString(string key)
        {
            if (DataString.ContainsKey(key))
            {
                return DataString[key];
            }
            throw new ArgumentException("La llave no existe");
        }

        public T GetObject<T>(string key)
        {
            if (DataObject.ContainsKey(key))
            {
                return (T)DataObject[key];
            }
            throw new ArgumentException("La llave no existe");
        }

        public void StartIntent()
        {
            Navigation.Intent = this;
            _startPage.Navigation.PushAsync(_endPage, true);
        }
        public class Navigation
        {
            public static Intent Intent { get; set; }
        }
    }
}
