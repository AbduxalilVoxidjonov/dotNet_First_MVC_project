namespace project1.Models
{
    public interface IStaffInterface
    {
        Staff GetStaffById(int id);

        IEnumerable<Staff> GetAll();

    }
}
