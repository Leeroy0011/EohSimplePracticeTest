using Eoh_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Eoh_DataService
{
    [ServiceContract]
    public interface IService1
    {
      
        [OperationContract]
        List<Person> GetPersons();
     
        [OperationContract]
        List<Employee> GetEmployee();

        [OperationContract]
        Person GetPersonsById(int id);

        [OperationContract]
        Employee GetEmployeeById(int id);

        [OperationContract]
        void InsertEmployee(Employee pobj);

        [OperationContract]
        void InsertPerson(Person pobj);

        [OperationContract]
        void UpdateEmployee(Employee pobj);

        [OperationContract]
        void UpdatePerson(Person pobj);

        [OperationContract]
        void DeleteEmployee(int id);

        [OperationContract]
        void DeletePerson(int id);


    }
    //// Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
        [DataMember(IsRequired = false)]
        public DateTime TerminatedDate { get; set; }
    }
}
