using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BirthdayBaBy.DelegateBirthdayBaBy;

namespace BirthdayBaBy
{
    class Program
    {
        static void Main(string[] args)
        {
            BaBy bb = new BaBy();
            bb.Guests("01");
            bb.Guests("12");
            bb.Guests("23");
            bb.Guests("34");
            bb.BirthdayBaBy += ShowMess;
            bb.Birthday = "01/01/2022";
        }
        public static void ShowMess(string birthday, string phoneNumber)
        {
            Console.WriteLine("Em be da chao doi vao ngay: {0} - Moi ban {1} den chung vui voi gia dinh chung toi", birthday.ToString(), phoneNumber);
        }
    }
}
