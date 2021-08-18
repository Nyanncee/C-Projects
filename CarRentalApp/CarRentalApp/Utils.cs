using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public static class Utils
    {
        public static bool FormIsOpen(string name)
        {
            //Check if window is already open
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == name);
            return isOpen;
        }

        //public static string hashedpassword(string password)
        //{
        //    sha256 sha = sha256.create();


        //    convert the input string to a byte aray and compute the hash
        //    byte[] data = sha.computehash(encoding.utf8.getbytes("password@123"));

        //    create a new stringbuilder to collect the bytes and create a string
        //    stringbuilder sbuilder = new stringbuilder();

        //    loop through each byte of the hashed data
        //    and format each one as a hexadecimal string
        //    for (int i = 0; i < data.length; i++)
        //    {
        //        sbuilder.append(data[i].tostring("x2"));
        //    }
        //    return sbuilder.tostring();
        //}
        //public static string defaulthashedpassword()
        //{
        //    sha256 sha = sha256.create();


        //    convert the input string to a byte aray and compute the hash
        //    byte[] data = sha.computehash(encoding.utf8.getbytes("password@123"));

        //    create a new stringbuilder to collect the bytes and create a string
        //    stringbuilder sbuilder = new stringbuilder();

        //    loop through each byte of the hashed data
        //    and format each one as a hexadecimal string
        //    for (int i = 0; i < data.length; i++)
        //    {
        //        sbuilder.append(data[i].tostring("x2"));
        //    }
        //    return sbuilder.tostring();
        //}
    }
}