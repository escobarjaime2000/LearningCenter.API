namespace Learning_Center.API03.Shared.Domain.Services.Communication;
//clase abstracta y generica
public class BaseResponse <T>
{
    
    //constructores
    public BaseResponse(T resource)
    {
        Success = true; //respuesta positiva
        Resource = resource;// representa la data 
        Message = string.Empty; //en blanco segun C#
    }
    
    public BaseResponse(string message)
    {
        Success = false;
        Resource = default;
       Message = message;
    }

//Properties
    public bool Success { get; private set; }
    public string Message { get; private set; }
    public T Resource { get; private set; }
    
    
    
    
}