using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
      //Çıplak class kalmasın
    public class PersonManager: IApplicantService
    {
        //encapsulation
        public void ApplyForMask (Person person)
        {
            throw new NotImplementedException();
        }
        
      
        public List<Person> GetList()
        {
            throw new NotSupportedException();
            
        }

        public bool Checkperson(Person person)
        {
            KPSPublicSoapClient client = new(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
                (new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody
                (person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;

        }
    



    }
        }


    
   

