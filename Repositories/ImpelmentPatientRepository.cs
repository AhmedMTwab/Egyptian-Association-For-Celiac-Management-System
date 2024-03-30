using Egyptian_association_of_cieliac_patients.Models;
using Egyptian_association_of_cieliac_patients.Repositories;
using Egyptian_association_of_cieliac_patients.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace TestCoreApp.Repository
{
    public class ImpelmentPatientRepository : IPatientRepo
    {
        public ImpelmentPatientRepository(EgyptianAssociationOfCieliacPatientsContext context)
        {
            this.context = context;
        }

        protected EgyptianAssociationOfCieliacPatientsContext context;

        public Patient FindById(int id)
        {
            return context.Set<Patient>().Find(id);
        }

        public Patient SelectOne(Expression<Func<Patient, bool>> match)
        {
            return context.Set<Patient>().SingleOrDefault(match);
        }

        public IEnumerable<Patient> FindAll()
        {
            return context.Set<Patient>().ToList();
        }

        public async Task<Patient> FindByIdAsync(int id)
        {
            return await context.Set<Patient>().FindAsync(id);
        }

        public async Task<IEnumerable<Patient>> FindAllAsync()
        {
            return await context.Set<Patient>().ToListAsync();
        }

        public IEnumerable<Patient> FindAll(params string[] agers)
        {
            IQueryable<Patient> query = context.Set<Patient>();

            if (agers.Length > 0)
            {
                foreach (var ager in agers)
                {
                    query = query.Include(ager);
                }
            }

            return query.ToList();
        }

        public async Task<IEnumerable<Patient>> FindAllAsync(params string[] agers)
        {
            IQueryable<Patient> query = context.Set<Patient>();

            if (agers.Length > 0)
            {
                foreach (var ager in agers)
                {
                    query = query.Include(ager);
                }
            }

            return await query.ToListAsync();
        }

        //=========================================================================//

        public void AddOne(Patient myItem)
        {
            context.Set<Patient>().Add(myItem);
            context.SaveChanges();
        }

        public void UpdateOne(Patient myItem)
        {
            context.Set<Patient>().Update(myItem);
            context.SaveChanges();
        }

        public void DeleteOne(Patient myItem)
        {
            context.Set<Patient>().Remove(myItem);
            context.SaveChanges();
        }

        public void AddList(IEnumerable<Patient> myList)
        {
            context.Set<Patient>().AddRange(myList);
            context.SaveChanges();
        }

        public void UpdateList(IEnumerable<Patient> myList)
        {
            context.Set<Patient>().UpdateRange(myList);
            context.SaveChanges();
        }

        public void DeleteList(IEnumerable<Patient> myList)
        {
            context.Set<Patient>().RemoveRange(myList);
            context.SaveChanges();
        }

       
    }
}