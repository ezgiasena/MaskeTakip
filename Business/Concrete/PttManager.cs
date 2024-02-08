using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _applicanService;
        public PttManager(IApplicantService applicantService) //Constructor(olusturucu) pttmanager newlendiginde once bu blog calisir. parantez icindeki sey de applicann servise de bagli demek
        {
            _applicanService = applicantService;
        }
        public void GiveMask(Person person)
        {
            
            if(_applicanService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " icin maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " icin maske verilemedi");
            }
        }
    }
}
