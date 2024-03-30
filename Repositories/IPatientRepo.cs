using Egyptian_association_of_cieliac_patients.Models;
using Egyptian_association_of_cieliac_patients.ViewModels;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Egyptian_association_of_cieliac_patients.Repositories
{
    public interface IPatientRepo
    {
            Patient FindById(int id);

        Patient SelectOne(Expression<Func<Patient, bool>> match);

            IEnumerable<Patient> FindAll();

            IEnumerable<Patient> FindAll(params string[] agers);

            Task<Patient> FindByIdAsync(int id);

            Task<IEnumerable<Patient>> FindAllAsync();

            Task<IEnumerable<Patient>> FindAllAsync(params string[] agers);

            void AddOne(Patient myItem);

            void UpdateOne(Patient myItem);

            void DeleteOne(Patient myItem);

            void AddList(IEnumerable<Patient> myList);

            void UpdateList(IEnumerable<Patient> myList);

            void DeleteList(IEnumerable<Patient> myList);
          
        }
    }
