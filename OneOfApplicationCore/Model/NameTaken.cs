namespace OneOfApplicationCore.Model
{
    public struct NameTaken
    {
        public NameTaken(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}
