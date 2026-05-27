using TopLearnWithDDD.Domain.DomainEvents;
using TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions;
using TopLearnWithDDD.Domain.ValueObjects;
using TopLearnWithDDD.Shared.Abstraction.Domain;

namespace TopLearnWithDDD.Domain.Entities.CourseManagement
{
    public class Course : AggregateRoot<BaseId>
    {
        private Title _title;
        private Description _description;
        private bool _isFree;
        private Price _price;
        private BaseId _instructorId;

        private LinkedList<CourseAttendee> _coursesAttendee;
        private LinkedList<CourseCatalog> _coursesCatalog;

        internal Course(BaseId id, Title title, Description description, bool isFree, Price price, BaseId instructorId)
        {
            Id = id;
            _title = title;
            _description = description;
            _isFree = isFree;
            _price = price;
            _instructorId = instructorId;
            RaiseDomainEvent(new NewCourseCreatedEvent(this));
        }
        public Course()
        {

        }

        #region Course Attendee Activities
        public void AddCourseAttendee(CourseAttendee courseAttendee)
        {
            var attendeeExist = _coursesAttendee.Any(a => a.Id == courseAttendee.Id);

            if (attendeeExist)
            {
                throw new CourseAttendeeAlreadyExistsException();
            }

            _coursesAttendee.AddLast(courseAttendee);
            RaiseDomainEvent(new CourseAttendeeAddedEvent(courseAttendee, this));
        }

        public void RemoveCourseAttendee(BaseId id)
        {
            var attendee = GetAttendee(id);
            _coursesAttendee.Remove(attendee);
        }

        private CourseAttendee GetAttendee(BaseId id)
        {
            var Attendee = _coursesAttendee.FirstOrDefault(a => a.Id == id);

            if (Attendee == null)
            {
                throw new CourseAttendeeNotFoundException();
            }

            return Attendee;
        }
        #endregion

        #region Course Catalog Activities
        public void AddCourseCatalog(CourseCatalog courseCatalog)
        {
            var attendeeExist = _coursesCatalog.Any(a => a.Id == courseCatalog.Id);

            if (attendeeExist)
            {
                throw new CourseCatalogAlreadyExistsException();
            }

            _coursesCatalog.AddLast(courseCatalog);
        }

        public void RemoveCourseCatalog(BaseId id)
        {
            var catalog = GetCatalog(id);
            _coursesCatalog.Remove(catalog);
        }

        private CourseCatalog GetCatalog(BaseId id)
        {
            var catalog = _coursesCatalog.FirstOrDefault(a => a.Id == id);

            if (catalog == null)
            {
                throw new CourseCatalogNotFoundException();
            }

            return catalog;
        }
        #endregion
    }
}