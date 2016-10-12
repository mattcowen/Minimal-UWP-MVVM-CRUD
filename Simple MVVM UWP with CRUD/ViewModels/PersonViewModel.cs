using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data;

namespace ViewModels
{
    public class PersonViewModel : NotificationBase<Person>
    {
        public PersonViewModel(Person person = null) : base(person) { }
        public String Name
        {
            get { return This.Name; }
            set { SetProperty(This.Name, value, () => This.Name = value); }
        }
        public String Line1
        {
            get { return This.Line1; }
            set { SetProperty(This.Line1, value, () => This.Line1 = value); }
        }
        public String Line2
        {
            get { return This.Line2; }
            set { SetProperty(This.Line2, value, () => This.Line2 = value); }
        }
        public String Line3
        {
            get { return This.Line3; }
            set { SetProperty(This.Line3, value, () => This.Line3 = value); }
        }
        public String City
        {
            get { return This.City; }
            set { SetProperty(This.City, value, () => This.City = value); }
        }
        public String County
        {
            get { return This.County; }
            set { SetProperty(This.County, value, () => This.County = value); }
        }

        public String Postcode
        {
            get { return This.Postcode; }
            set { SetProperty(This.Postcode, value, () => This.Postcode = value); }
        }
        public int Age
        {
            get { return This.Age; }
            set { SetProperty(This.Age, value, () => This.Age = value); }
        }
    }
}
