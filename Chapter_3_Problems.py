import math

# Exercise 3.1.
print('exercise 3.1.')
def right_justify(s):
    print(' ' * (70 - len(s)) + s)
right_justify('hello')


print("\n" + "=" * 40 + "\n")


# Exercise 3.2.
print('exercise 3.2.')
def do_twice(f):
    f()
    f()
def print_spam():
    print('spam')

do_twice(print_spam)


print("\n" + "=" * 40 + "\n")


# Problem 2
print('problem 2')
def do_twice(function, f):
    function(f)
    function(f)
def print_spam(word):
    print(word)

do_twice(print_spam, 'spam')


print("\n" + "=" * 40 + "\n")


# Problem 4
print('problem 4')
def do_twice(function, f):
    function(f)
    function(f)
def print_twice(g):
    print(g)
    print(g)

do_twice(print_twice, 'spam')


print("\n" + "=" * 40 + "\n")


# Problem 5
print('problem 5')
def do_twice(function, a):
    function(a)
    function(a)
def print_twice(g):
    print(g)
    print(g)
def do_four(function, a):
    do_twice(function, a)
    do_twice(function, a)


do_four(print_twice, 'spam')


print(f"\n{'=' * 40}\n")


# Exercise 3.3.
print('exercise 3.3.')
def do_first():
    print('+', end=' ')
    print('- ' * 4, end='')
    print('+', end=' ')
    print('- ' * 4, end='')
    print('+')
do_first()
def do_twice(column,g):
    column(g)
    column(g)
def do_four(column, g):
    do_twice(column, g)
    do_twice(column, g)
def print_second(s):
    print(('|'+ s) + ('|'+ s) + ('|'))
do_four(print_second, ' '*9)
do_first()
do_four(print_second, ' '*9)
do_first()


print(f"\n{'=' * 40}\n")


print('problem 2')
def do_first():
    print('+', end=' ')
    print('- ' * 4, end='')
    print('+', end=' ')
    print('- ' * 4, end='')
    print('+', end=' ')
    print('- ' * 4, end='')
    print('+', end=' ')
    print('- ' * 4, end='')
    print('+')
do_first()
def do_twice(column,g):
    column(g)
    column(g)
def do_space(column, g):
    do_twice(column, g)
    do_twice(column, g)
def print_second(s):
    print(('|'+ s) + ('|'+ s) + ('|'+ s) + ('|'+ s) + ('|'))
do_space(print_second, ' '*9)
do_first()
do_space(print_second, ' '*9)
do_first()
do_space(print_second, ' '*9)
do_first()
do_space(print_second, ' '*9)
do_first()