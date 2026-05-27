using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class VideoUrlNullOrEmptyException : CourseManagementException
    {
        public VideoUrlNullOrEmptyException() : base("VideoUrl Can Not Be Empty")
        {
            
        }
    }
}
