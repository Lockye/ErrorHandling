namespace OneOfApplicationCore.Model
{
    public struct NameNotValid
    {
        public NameNotValid(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}
