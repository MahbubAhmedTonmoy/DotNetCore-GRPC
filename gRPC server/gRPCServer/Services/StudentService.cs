using Grpc.Core;
using gRPCServer.Data;
using gRPCServer.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gRPCServer.Services
{
    public class StudentService : Student.StudentBase
    {
        public StudentService()
        {

        }
        public override Task<StudentModel> GetStudentById(GetStudentByIdModel request, ServerCallContext context)
        {
            var student = StudentData.students.Where(p => p.StudentId == request.StudentId).FirstOrDefault();
            return Task.FromResult(student);
        }
    }
}
