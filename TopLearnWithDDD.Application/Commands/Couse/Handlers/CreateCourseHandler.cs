using TopLearnWithDDD.Domain.Factories.CourseManagement;
using TopLearnWithDDD.Domain.Repositories.CourseManagement;
using TopLearnWithDDD.Shared.Abstraction.Commands;

namespace TopLearnWithDDD.Application.Commands.Couse.Handlers
{
    public class CreateCourseHandler : ICommandHandler<CreateCourse>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly ICourseFactory _courseFactory;

        public CreateCourseHandler(ICourseRepository courseRepository, ICourseFactory courseFactory)
        {
            _courseRepository = courseRepository;
            _courseFactory = courseFactory;
        }

        public async Task HandleAsync(CreateCourse command)
        {
            var course = _courseFactory.Create(command.id, command.title, command.description, command.isFree, command.price, command.instructorId);
            await _courseRepository.AddAsync(course);
        }
    }
}
