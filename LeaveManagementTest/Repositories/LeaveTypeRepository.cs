using LeaveManagementTest.Contracts;
using LeaveManagementTest.Data;

namespace LeaveManagementTest.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }

    }
}
