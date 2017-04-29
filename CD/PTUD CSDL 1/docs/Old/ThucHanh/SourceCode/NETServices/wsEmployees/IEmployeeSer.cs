using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using wsEmployees.dao;
namespace wsEmployees
{
    [ServiceContract]
    interface IEmployeeSer
    {
        [OperationContract]
        List<NhanVien> getall();
        [OperationContract]
        void create(NhanVien nv);
        [OperationContract]
        void delete(int id);
        [OperationContract]
        void update(NhanVien nv);



    }
}
