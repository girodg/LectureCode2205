using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class BankAccount
    {
        //access modifiers:
        //public: everyone can see it
        //private (default): ONLY this class (BankAccount) can see it
        //protected: BankAccount and all child (derived) class

        //FIELDS (data)
        //generally, make them private until needed elsewhere
        //C# naming convention: _camelCasing
        private int _routing, _accountNumber;
        private double _balance;

        //PROPERTIES (gatekeepers of the data)
        //C# naming convention: PascalNamingConvention
        //full property. there is a backing field
        public int RoutingNumber
        {
            //getter (accessor)
            //same as public int GetRoutingNumber() {return _routing;}
            get 
            { 
                return _routing; 
            }

            //setter (mutator)
            //same as public void SetRoutingNumber(int value) { _routing = value;}
            set //hidden parameter called 'value'
            {
                if(value > 0)
                    _routing = value;
            }
        }

        //auto-property. the compiler will write the code inside of my get and set AND give me a field
        public string BankName { get; private set; }

        //CONSTRUCTORS
        //ctor = constructor
        public BankAccount(string bank, int routing, int acctNum, double balance)//default constructor (no parameters)
        {
            //local variables and parameters follow camelCasingNamingConvention
            //assign the parameters to your properties/fields
            BankName = bank;
            RoutingNumber = routing;
            _accountNumber = acctNum;
            _balance = balance;

            //balance = _balance;//BACKWARDS and WRONG!
        }
    }
}
