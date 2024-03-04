using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person);

        List<Person> GetList();
 
        bool CheckPerson(Person person);


    }
}
//İnterfacede sadece metot imzaları bulunur  ve gövdesi içeriği bulunmaz