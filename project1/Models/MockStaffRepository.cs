
namespace project1.Models
{
    public class MockStaffRepository : IStaffInterface
    {
        private  List<Staff> _staffList=null;
        public MockStaffRepository()
        {
            _staffList = new List<Staff>()
            {
                new Staff(){Id=1,firstName="John",lastName="Doe",email="1",department="english"},
                new Staff(){Id=2,firstName="Al",lastName="Doe",email="2",department="uzbek"},
                new Staff(){Id=3,firstName="Jhn",lastName="Doe",email="3",department="korean"},
                new Staff(){Id=4,firstName="hn",lastName="Doe",email="4",department="russian"},
                new Staff(){Id=5,firstName="n",lastName="Doe",email="5",department="ansada"}
            };
            
        }

        public IEnumerable<Staff> GetAll()
        {
            return _staffList;
        }

        Staff IStaffInterface.GetStaffById(int id)
        {
            return _staffList.FirstOrDefault(s => s.Id == id);
        }
    }
}
