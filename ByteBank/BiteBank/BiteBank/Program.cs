using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Employees;
using ByteBank.Systems;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            //MathBonus();

            intenalSystem();


            Console.ReadLine();
        }
        public static void MathBonus()
        {
            ManagerBonus managerBonus = new ManagerBonus();

            Auxiliar igor = new Auxiliar("357.753.357-01");
            igor.Name = "Igor";
            
            Designer peter = new Designer("159.951.159-01");
            peter.Name = "Peter";

            Developer cris = new Developer("794.613.987-01");
            cris.Name = "Cris";

            AccountManager camily = new AccountManager("852.258.852-01");
            camily.Name = "Camily";

            Director charles = new Director("123.321.123-01");
            charles.Name = "Cris";

            managerBonus.Register(igor);
            managerBonus.Register(peter);
            managerBonus.Register(cris);
            managerBonus.Register(camily);
            managerBonus.Register(charles);

            Console.WriteLine("Total bonus' month: " + managerBonus.TotalBonus());

            Console.ReadLine();
        }
        public static void intenalSystem()
        {
            InternalSystem internalSystem = new InternalSystem();


            AccountManager camily = new AccountManager("852.258.852-01");
            camily.Name = "Camily";
            camily.Password = "123";

            Director charles = new Director("123.321.123-01");
            charles.Name = "Charles";
            charles.Password = "456";

            TradePartner tradePartner = new TradePartner();
            tradePartner.Password = "123456";


            internalSystem.Login(camily, "123");
            internalSystem.Login(charles, "456");
            internalSystem.Login(tradePartner, "123456");


        }

    }
}
