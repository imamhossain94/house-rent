using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace House_Rent.Classes
{
    class RegistryMd5
    {
        Microsoft.Win32.RegistryKey key;
        static string Regname = "Software\\NewAgeBD\\House Rent";
        public string text { get; set; }
        public int trialDay;

        //MD5Hash 2x____________________________________________________________________________
        public string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        //MD5Hash 3x____________________________________________________________________________
        public string MD5Hashx3(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x3"));
            }
            return hash.ToString();
        }

        //MD5Hash 5x____________________________________________________________________________
        public string MD5Hashx5(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x5"));
            }
            return hash.ToString();
        }




        //Md5Hash2String__________________________________________________________________
        public static string GetHex(byte[] md5Array, bool isUpper)
        {
            var builder = new StringBuilder(md5Array.Length * 2);
            for (var i = 0; i < md5Array.Length; i++)
            {
                builder.Append(md5Array[i].ToString(isUpper ? "X2" : "x2"));
            }

            return builder.ToString();
        }

        //String2Hexa_______________________________________________________________________
        public string ToHexString(string str)
        {
            var sb = new StringBuilder();
            var bytes = Encoding.Unicode.GetBytes(str);
            foreach (var t in bytes)
            {
                sb.Append(t.ToString("X2"));
            }
            return sb.ToString();
        }

        //Hexa2String_______________________________________________________________________
        public string FromHexString(string hexString)
        {
            var bytes = new byte[hexString.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }
            return Encoding.Unicode.GetString(bytes);
        }


        //Single reg value_______________________________________________________________________
        public bool writeRegistryKey(string Key, string value)
        {
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(Regname);
            key.SetValue(Key, value);
            key.Close();
            return true;
        }

        //Multi reg value________________________________________________________________________
        public bool writeRegistryKey(string Key, string[] value)
        {
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(Regname);
            key.SetValue("hrcd", value);
            key.Close();
            return true;
        }

        //-----------------------------------------Trial Calculator------------------------------------
        int d, m, y;
        int[] monthDays= new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public void setval(int x,int y,int z)
        {
            this.d = x;
            this.m = y;
            this.y = z;
        }

        public int countLeapYears(RegistryMd5 d)
        {
          int years = d.y;
          if (d.m <= 2)
              years--;
           return years / 4 - years / 100 + years / 400;
        }

        public int getDifference(RegistryMd5 dt1, RegistryMd5 dt2)
        {
            int n1 = dt1.y * 365 + dt1.d;
            for (int i = 0; i < dt1.m - 1; i++)
                n1 += monthDays[i];

            n1 += countLeapYears(dt1);
            int n2 = dt2.y * 365 + dt2.d;
            for (int i = 0; i < dt2.m - 1; i++)
                n2 += monthDays[i];

            n2 += countLeapYears(dt2);
            return (n2 - n1);
        }

        public void getRemainingTrialDay()
        {
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Regname, true);

            if (key == null)
            {
                key = key.CreateSubKey(Regname);
            }
            key.Close();

            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Regname, true);

            int day, month, year;
            int d, m, y;
            var time = DateTime.Now;
            

            day = Convert.ToInt32(FromHexString(key.GetValue("InsD").ToString()));
            month = Convert.ToInt32(FromHexString(key.GetValue("InsM").ToString()));
            year = Convert.ToInt32(FromHexString(key.GetValue("InsY").ToString()));

            d = Convert.ToInt32(time.ToString("dd"));
            m = Convert.ToInt32(time.ToString("MM"));
            y = Convert.ToInt32(time.ToString("yyyy"));

            RegistryMd5 date1 = new RegistryMd5();
            date1.setval(day, month, year);

            RegistryMd5 date2 = new RegistryMd5();
            date2.setval(d, m, y);
            trialDay = getDifference(date1, date2);

            key.Close();
        }

        //--------------------------------Check version---------------------------------
        public string checkVer()
        {


            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Regname, true);

            if (key == null)
            {
                key = key.CreateSubKey(Regname);
            }
            key.Close();

            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Regname, true);

            if (key.GetValue("ProdT").ToString() == MD5Hashx5("NeoRentAgeTril"))
            {
                if(trialDay>=30)
                {
                    return "expired";
                }
                else
                {
                    return "trial";
                }
            }
            if (key.GetValue("ProdT").ToString() == MD5Hashx3("NeoNewPaidHouseRent"))
            {
                return "paid";
            }

            key.Close();

            return "";
        }

    }
}
