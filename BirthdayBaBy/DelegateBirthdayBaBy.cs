using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayBaBy
{
    class DelegateBirthdayBaBy
    {
		public delegate void EnventBirthdayBaBy(string birthday, string listPhoneNumber);

		public class BaBy
		{
			public event EnventBirthdayBaBy BirthdayBaBy;
			public string[] listPhone;
			public string birthday;

			public BaBy()
			{
				listPhone = new string[0];
			}

			public string Birthday
			{
				get
				{
					return birthday;
				}
				set
				{
					birthday = value;
					if (BirthdayBaBy != null && listPhone.Length > 0)
					{
						foreach (var item in listPhone)
						{
							BirthdayBaBy(value, item);
						}
					}
				}
			}
			public void Guests(string guests)
			{
				if (listPhone.Length == 0)
				{
					listPhone = new string[1];
					listPhone[0] = guests;
				}
				else
				{
					string[] listPhoneNew = new string[listPhone.Length + 1];
					for (int i = 0; i < listPhone.Length; i++)
					{
						listPhoneNew[i] = listPhone[i];
					}
					listPhoneNew[listPhone.Length] = guests;
					listPhone = listPhoneNew;
				}
			}

		}
	}
}
