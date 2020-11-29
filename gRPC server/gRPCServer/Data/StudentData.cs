using gRPCServer.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gRPCServer.Data
{
    public class StudentData
    {
        public static List<StudentModel> students = new List<StudentModel>
        {
            new StudentModel
            {
                StudentId = 1,
                Name = "Pepsi"
            },
            new StudentModel
            {
                StudentId = 2,
                Name = "Fanta"
            }
        };
    }
}
