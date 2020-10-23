
namespace Fleet.Domain.Dtos.Bus
{
    public class UpdateResult
    {
        public UpdateResult(bool updated)
        {
            Updated = updated;
        }

        public bool Updated { get; set; }
    }
}
