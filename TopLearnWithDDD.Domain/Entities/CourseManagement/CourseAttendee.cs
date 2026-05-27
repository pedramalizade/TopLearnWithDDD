using TopLearnWithDDD.Domain.Primitives;
using TopLearnWithDDD.Domain.ValueObjects;

namespace TopLearnWithDDD.Domain.Entities.CourseManagement
{
    public class CourseAttendee : BaseEntity
    {
        private BaseId _coursId;
        private BaseId _userId;

        internal CourseAttendee(BaseId id, BaseId coursId, BaseId userId) : base(id)
        {
            _coursId = coursId;
            _userId = userId;
        }

        public CourseAttendee(BaseId id) : base(id) 
        {
            
        }
    }
}
