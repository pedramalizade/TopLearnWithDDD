using TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions;

namespace TopLearnWithDDD.Domain.ValueObjects
{
    public record VideoUrl
    {
        public string Value { get; }

        public VideoUrl(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new VideoUrlNullOrEmptyException();
            }

            if (value.Length > 50)
            {
                throw new InvalidVideoUrlLengthException(50);
            }

            if (!value.EndsWith(".mp4"))
            {
                throw new InvalidVideoExtentionExceptio();
            }

            Value = value;
        }

        public static implicit operator string(VideoUrl videoUrl) => videoUrl.Value;
        public static implicit operator VideoUrl(string videoUrl) => new VideoUrl(videoUrl);
    }
}
