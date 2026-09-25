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

