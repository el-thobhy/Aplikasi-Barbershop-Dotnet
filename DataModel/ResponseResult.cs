namespace AplikasiBarbershop.DataModel
{
    public class ResponseResult
    {
        public ResponseResult()
        {
            Success = true;
        }
        public bool Success { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }
    }
}
