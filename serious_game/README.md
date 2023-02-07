# Pirate Stroop
PIRATE STROOP is a platform 3D pirate themed videogame developed to train children, between 7 and 8 years old, with ADHD by adapting the principles of 
[Stroop Test](https://en.wikipedia.org/wiki/Stroop_effect) to an interactive collecting challenge<br>

<p align=center>
<img src="/imgs/title.png" alt="">
</p>

# Gameplay
The aim of the game is to collect coins/gems matching them to the provided stimuli by moving leftward or rightward. <br>
There are three type of stimuli:
- **congruent**: asked to match the shape with all the options colored in black
- **incongruent**: asked to match the color with the options different in shapes and colors
- **challenging incongruent**: asked to match either the share or the color with the options different in shapes and colors

<p align=center>
<img src="/imgs/game.png" alt="">
</p>

# Data Collected
After each session a JSON file is produced recording the overall accuracy for the session and the reaction time for each stimuli.

```text
{
    "Accuracy": 0.95,
    "Reaction": [
        3.88,
        3.71,
        3.99,
        2.56,
        4.01.
        ...
    ]
}
```
