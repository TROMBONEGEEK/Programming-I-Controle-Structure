import turtle
import tkinter as tk

def on_key_press(event):
    key = event.keysym

    if key == "Up":
        print("Command: Move UP")
    elif key == "Down":
        print("Command: Move DOWN")
    elif key == "Left":
        print("Command: Move LEFT")
    elif key == "Right":
        print("Command: Move RIGHT")


turtle.setup(400, 500)
wn = turtle.Screen()
wn.title("Handling Mouse clicks!")
wn.bgcolor("lightgreen")
tess = turtle.Turtle()
tess.color("darkgreen")
alex = turtle.Turtle()
alex.color("blue")
alex.forward(100)

def handler_for_tess(x, y):
    wn.title("Tess clicked at {0}, {1}" .format(x, y))
    tess.left(42)
    tess.forward(30)

def handler_for_alex(x, y):
    wn.title("Alex clicked at {0}, {1}" .format(x, y))
    alex.forward(50)
    alex.left(23)
    

tess.onclick(handler_for_tess)
alex.onclick(handler_for_alex)

wn.mainloop()

import turtle

turtle.setup(400, 500)
wn = turtle.Screen()
wn.title("handling Mouse clicks!")
wn.bgcolor("lightgreen")

tess = turtle.Turtle()
tess.color ("darkgreen")

alex = turtle.Turtle()
alex.color("blue")
alex.forward(100)

def handler_for_screen(x, y):
    wn.title("Clicked at {0}, {1}" .format(x, y))

    tess.setheading(tess.towards(x, y))
    tess.forward(30)

wn.onclick(handler_for_screen)

wn.listen()

wn.mainloop()