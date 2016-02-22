using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;

namespace WcfServiceClickView
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "Service1" nel codice, nel file svc e nel file di configurazione contemporaneamente.
    public class VlkCheck : IVlkCheck
    {
        public string GetData(string m)
        {
            StringBuilder mySB = new StringBuilder("");

            if (ServiceSecurityContext.Current != null)
            {
                mySB.AppendLine("c'è un context");
                mySB.AppendLine(string.Format("Is authenticated: {0}", ServiceSecurityContext.Current.PrimaryIdentity.IsAuthenticated));
                mySB.AppendLine(string.Format("Authentication Type: {0}", ServiceSecurityContext.Current.PrimaryIdentity.AuthenticationType));
                mySB.AppendLine(string.Format("Authentication Name: {0}", ServiceSecurityContext.Current.PrimaryIdentity.Name));
            }
            else
            {
                mySB.AppendLine("NON c'è un context");
            }

            return mySB.ToString() + string.Format("You entered: {0}", m);
        }

        public string ChiamataPost(Stream st)
        {
            StreamReader sr = new StreamReader(st);
            string aa = sr.ReadToEnd();
            sr.Close();

            return string.Format("You entered: {0}" , aa);
        }


        public string ChiamataJsonComplessa(MultiValue mv)
        {
            return mv.nome + " - " + mv.cognome;
        }


        public string ChiamataJson(string id)
        {
            StringBuilder mySB = new StringBuilder("");

            if (ServiceSecurityContext.Current != null)
            {
                mySB.AppendLine("c'è un context");
                mySB.AppendLine(string.Format("Is authenticated: {0}", ServiceSecurityContext.Current.PrimaryIdentity.IsAuthenticated));
                mySB.AppendLine(string.Format("Authentication Type: {0}", ServiceSecurityContext.Current.PrimaryIdentity.AuthenticationType));
                mySB.AppendLine(string.Format("Authentication Name: {0}", ServiceSecurityContext.Current.PrimaryIdentity.Name));
            }else
            {
                mySB.AppendLine("NON c'è un context");
            }
            

            return mySB.ToString() + "-->" + id + "<-----" ;
        }


        //public string ChiamataComposta(string id)
        //{
        //    return "-->" + id + "<-----";
        //}

        //public string ChiamataPost(string id)
        //{

        //    return string.Format("You entered: {0}", id);
        //}

        //public string ChiamataPost(string id, Stream st)
        //{
        //    StreamReader sr = new StreamReader(st);
        //    string aa = sr.ReadToEnd();
        //    sr.Close();

        //    return string.Format("You entered: {0}", id);
        //}



        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}





        public string CallPostNoPar()
        {
            return "OK!!!";
        }




    }
}
