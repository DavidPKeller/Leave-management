using Leave_management.Contracts;
using Leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_management.Repository
{
    
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db; 
        }


        public bool Create(LeaveType entity)
        {
            _db.LeaveTypes.Add(entity);

            return Save();


        }

        public bool Delete(LeaveType entity)
        {
            _db.Remove(entity);
            return Save();
        }

        public ICollection<LeaveType> FindAll()
        {
            var leaveTypes = _db.LeaveTypes.ToList();

            return leaveTypes;

            //Also:  return _db.LeaveTypes.ToList();
        
        }

        public LeaveType FindById(int id)
        {
            var leaveType = _db.LeaveTypes.Find(id);
            
            return leaveType;
        }

        public ICollection<LeaveType> GetEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            
            return changes > 0;

          //ALSO:  return  _db.SaveChanges() > 0 ;
        }

        public bool Update(LeaveType entity)
        {
            _db.LeaveTypes.Update(entity);

            return Save();

        }
    }
}
