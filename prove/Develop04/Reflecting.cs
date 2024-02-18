class Reflecting
{
    {
        public _prompts:List<string>
        public _questions:List<string>
    }
    {
        ReflectingActivity();
        Run():void;
        GetRandomPrompt():string;
        GetRandomQuestion():string;
        DisplayPrompt():void;
        DisplayQuestion():void;
    }
}