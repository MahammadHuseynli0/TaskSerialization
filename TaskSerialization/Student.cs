using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TaskSerialization
{
    [Serializable]
    internal class Student: ISerializable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id",Id, typeof(Student));
            info.AddValue("Name",Name, typeof(Student));
            info.AddValue("Surname", Surname, typeof(Student));
        }
    }
}
