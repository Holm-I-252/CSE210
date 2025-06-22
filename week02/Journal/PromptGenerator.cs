using System;

public class PromptGenerator
{
    private string[] prompts = new string[]
    {
        "What was the best part of your day?",
        "What are you grateful for today?",
        "Describe a challenge you faced and how you overcame it.",
        "What is something new you learned today?",
        "How did you help someone today?",
        "What made you smile today?",
        "What is a goal you want to achieve in the next week?",
        "Reflect on a recent success and what it taught you."
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }
}