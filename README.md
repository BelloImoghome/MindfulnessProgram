## MindfulnessProgram
A console app that provides three different kinds of mindfulness opportunities. It could give some guidance and structure to users in the following activities such as breathing, reflecting and listing activities.

## Mindfulness Program
# Problem Overview
We live in a fast-paced world full of stress and anxiety. We could each benefit from taking time for mindfulness activities where we can reflect and unwind.

Most people would agree that we should take more time to be mindful, but relatively few of us do. Think to yourself for a moment about some reasons that you think keep people from doing this. Could a program or an app help with any of these reasons?

Some of the problems you considered may have included:

1. We forget
2. We get busy
3. We think it will take too long, so we don't start
4. We don't know where to begin. We know we should reflect on something but don't know what to start with.
5. While it may not resolve all of the issues that keep people from taking more time for reflection, a great program could help people by providing structure and prompts to guide them through various exercises.

# Solution Idea
Consider an app that provides three different kinds of mindfulness opportunities. It could give some guidance and structure to users in the following activities:

A. Breathing Activity - Help the user pace their breathing to have a session of deep breathing for a certain amount of time. They might find more peace and less stress through the exercise.

B. Reflection Activity - Guide the user to think deeply, by having them consider a certain experience when they were successful or demonstrated strength. Then, prompt them with questions to reflect more deeply about details of this experience. They might discover more depth than they previously realized.

C. Listing Activity - Guide the user to think broadly, by helping them list as many things as they can in a certain area of strength or positivity. They might discover more breadth than they previously realized.
The application could additional help the user keep track of the time or frequency they spend in these activities and give them gentle prompts and reminders.

The user interface of a program like this could be anything from a Website or Mobile App to one that runs on a Smart Watch and it could be done in many different kinds of colors, shapes, and styles. Learning to write a program to solve the real-world problem is the most critical part, so this assignment will focus on that, rather than creating a flashy interface.

# Specification
Write a program that provides the three activities described above. It should help them work through these activities in stages using basic forms of delay (animation or countdown).

# Functional requirements
Your program must do the following:

1. Have a menu system to allow the user to choose an activity.
2. Each activity should start with a common starting message that provides the name of the activity, a description, and asks for and sets the duration of the activity in seconds. Then, it should tell the user to prepare to begin and pause for several seconds.
3. Each activity should end with a common ending message that tells the user they have done a good job, and pause and then tell them the activity they have completed and the length of time and pauses for several seconds before finishing.
4. Whenever the application pauses it should show some kind of animation to the user, such as a spinner, a countdown timer, or periods being displayed to the screen.
5. The interface for the program should remain generally true to the one shown in the video demo.
6. Provide activities for reflection, breathing, and enumeration, as described below:
### Breathing Activity
1. The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
2. The description of this activity should be something like: "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
3. After the starting message, the user is shown a series of messages alternating between "Breathe in..." and "Breathe out..."
4. After each message, the program should pause for several seconds and show a countdown.
4. It should continue until it has reached the number of seconds the user specified for the duration.
5. The activity should conclude with the standard finishing message for all activities.

### Reflection Activity
1. The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
2. The description of this activity should be something like: "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
3. After the starting message, select a random prompt to show the user such as:

i) Think of a time when you stood up for someone else.
ii) Think of a time when you did something really difficult.
iii) Think of a time when you helped someone in need.
iv) Think of a time when you did something truly selfless.
4. After displaying the prompt, the program should ask the to reflect on questions that relate to this experience. These questions should be pulled from a list such as the following:

i) Why was this experience meaningful to you?
ii) Have you ever done anything like this before?
iii) How did you get started?
iv) How did you feel when it was complete?
v) What made this time different than other times when you were not as successful?
vi) What is your favorite thing about this experience?
vii) What could you learn from this experience that applies to other situations?
viii) What did you learn about yourself through this experience?
ix) How can you keep this experience in mind in the future?
5. After each question the program should pause for several seconds before continuing to the next one. While the program is paused it should display a kind of spinner.
6. It should continue showing random questions until it has reached the number of seconds the user specified for the duration.
The activity should conclude with the standard finishing message for all activities.

### Listing Activity
1. The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
2. The description of this activity should be something like: "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
3. After the starting message, select a random prompt to show the user such as:

i) Who are people that you appreciate?
ii) What are personal strengths of yours?
iii) Who are people that you have helped this week?
iv) When have you felt the Holy Ghost this month?
v) Who are some of your personal heroes?

4. After displaying the prompt, the program should give them a countdown of several seconds to begin thinking about the prompt. Then, it should prompt them to keep listing items.
5. The user lists as many items as they can until they they reach the duration specified by the user at the beginning.
6. The activity then displays back the number of items that were entered.
7. The activity should conclude with the standard finishing message for all activities.
