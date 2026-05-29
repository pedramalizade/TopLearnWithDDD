using TopLearnWithDDD.Application.Exceptions;
using TopLearnWithDDD.Domain.Factories.CourseManagement;
using TopLearnWithDDD.Domain.Repositories.CourseManagement;
using TopLearnWithDDD.Shared.Abstraction.Commands;

namespace TopLearnWithDDD.Application.Commands.Couse.Handlers
{
    public class UpdateCourseHandler : ICommandHandler<UpdateCourse>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly ICourseFactory _courseFactory;

        public UpdateCourseHandler(ICourseRepository courseRepository, ICourseFactory courseFactory)
        {
            _courseRepository = courseRepository;
            _courseFactory = courseFactory;
        }

        public async Task HandleAsync(UpdateCourse command)
        {
            var course = await _courseRepository.GetAsync(command.id);
            if (course == null)
            {
                throw new CourseNotFoundException();
            }

            course = _courseFactory.Create(course.Id, command.title, command.description, command.isFree, command.price, command.instructorId);
            await _courseRepository.UpdateAsync(course);
        }
    }
}
