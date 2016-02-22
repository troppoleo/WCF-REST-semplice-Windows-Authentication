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
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IService1" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IVlkCheck
    {
        //[WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "m/{id}")]
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]    // richiamabile con http://localhost:39687/VlkCheck.svc/GetData?id={ID} 
        string GetData(string id);


        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
            UriTemplate = "/ChiamataJsonComplessa", ResponseFormat = WebMessageFormat.Json)]
        string ChiamataJsonComplessa(MultiValue mv);



        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat  = WebMessageFormat.Json,
            UriTemplate = "/ChiamataJson", ResponseFormat = WebMessageFormat.Json)]
        string ChiamataJson(string id);




        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/ChiamataPost", ResponseFormat=WebMessageFormat.Json)]    
        string ChiamataPost(Stream st);


        // OK!!
        //[OperationContract]
        //[WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "{id}")]
        //string ChiamataPost(string id, Stream st);



        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json, Method = "POST")]    // richiamabile con http://localhost:39687/VlkCheck.svc/CallPost 
        string CallPostNoPar();


        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: aggiungere qui le operazioni del servizio
    }



    [DataContract]
    public class MultiValue
    {
        [DataMember]
        public string nome {get; set;}

        [DataMember]
        public string cognome { get; set; }
    }

    // Per aggiungere tipi compositi alle operazioni del servizio utilizzare un contratto di dati come descritto nell'esempio seguente.
    //[DataContract]
    //public class CompositeType
    //{
    //    bool boolValue = true;
    //    string stringValue = "Hello ";

    //    [DataMember]
    //    public bool BoolValue
    //    {
    //        get { return boolValue; }
    //        set { boolValue = value; }
    //    }

    //    [DataMember]
    //    public string StringValue
    //    {
    //        get { return stringValue; }
    //        set { stringValue = value; }
    //    }
    //}
}
