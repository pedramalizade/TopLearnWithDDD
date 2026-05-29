using TopLearnWithDDD.Application.Exceptions;
using TopLearnWithDDD.Domain.Repositories.CourseManagement;
using TopLearnWithDDD.Shared.Abstraction.Commands;

namespace TopLearnWithDDD.Application.Commands.Couse.Handlers
{
    public class DeleteCourseHandler : ICommandHandler<DeleteCourse>
    {
        private readonly ICourseRepository _courseRepository;

        public DeleteCourseHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task HandleAsync(DeleteCourse command)
        {
            var course = await _courseRepository.GetAsync(command.id);
            if (course == null)
            {
                throw new CourseNotFoundException();
            }

            await _courseRepository.DeleteAsync(course);  
        }
    }
}
