import time

print("You wake up in a dark room.")
print("You do not recognize this room.")
time.sleep(2.5)
print("You cannot remember anyting.")

def space():
    for i in range(2):
        print("")

space()
print("Explore the room.")

key = "N"

window_times = 0
bookcase_times = 0

def explore():
    space()
    time.sleep(1)
    print("DOOR................D")
    print("CURTAINED WINDOW....W")
    print("CLOSET..............C")
    print("DESKTOP.............T")
    print("BOOKCASE............B")
    print("DRAWERS.............R")
    global choice 
    choice = input("Enter letter here:")

    if choice == "D":
        print("Door is firmly locked.")
        time.sleep(2.5)
        print("You do not want to get out.")
        explore()
    elif choice == "W":
        global window_times
        if window_times == 0:
            print
            print("You open the curtains.")
            print("You were mistaken. It is not a window. The curtains unveil a poster board.")
            print("There are photos, newspaper clippings, and posters of a musician named Matthew Zhang.")
            print("Hm. Seems successful and all. Sold out tours & high praises by media outlets and such.")
            print("The owner of this room must be a fan.")
            print("You will come back later.")
            window_times += 1
        else:
            print("You take down the poster board.")
            print("You find barred windows.")
            print("The back of the poster board: newspaper clippings of Matthew Zhang's scandals....")
            print("Red strings. Scratched out photos. Matthew Zhang is a fraud and scum in every sense of those words.")
            print("Something falls off the carefully put together board.")
            print("It's a small, printed picture of a teenage girl. It looks like it was cut out of a yearbook?")
        explore()
    elif choice == "T":
        print("There are scattered music sheets on the desk.")
        print("Compositions, guitar tabs, half-finished lyrics.")
        print("Titles: eclipse, next step, cloudy moons,", '\033[31mFAME\033[0m' ,"moon rise.")
        print("Are you in a musician's room?")
        time.sleep(2.5)
        print("Oh wait! A phone. Open it up and see.")
        pw = input("Please enter the 4 number password:")

        count = 0
        while count <= 3:
            if pw != "2152":
                print("Incorrect password. Try again.")
                count += 1
            else:
                print("Loading data....")
                break
            print("You have been locked out. There's no use in trying again.")
            print("HINT: Check the sheet music titles again. Maybe there's a clue there.")
            explore()
        space()
        print("You go through text messages.")
        print("You find that everyone in the chat history - Violet, Mom, Manager Steve, Sam, and Harper - have all blocked the owner of the phone. Strange.")
        yn = input("Look through chat history? Y or N:")
        if yn == "Y":
            print("You look through the chat history between the owner of the phone and the pinned contact, Violet.")
            space()
            print("VIOLET - 03:28 NOV 14 20XX")
            print("You disgust me.")
            print("Do not contact me again.")
            print()
            time.sleep(1)
            print("\033[31mMESSAGE SEND FAILURE\033[0m".center(20))
            print("\033[31mYOU - 05:17 NOV 14 20XX\033[0m")
            print("\033[31mhey. please\033[0m")
            print("\033[31mplease babe\033[0m")
            print("\033[31mplease it's not true\033[0m")
            print("\033[31mnone of it is true.....\033[0m")
            print("\033[31mi'm so sorry\033[0m")
            print("\033[31mi love you...\033[0m")
            time.sleep(1)
        elif yn == "N":
            print("You will take another look later. Looking through someone else's messages seems too intrusive.")
        print("")
        print("An incoming e-mail notification comes. You can't help but take a look.")
        print("SUBJECT: [IMPORTANT] Session Update")
        print("FROM: marcie.grace@vstherapy.com")
        print("hey matthew!")
        print("hope you're feeling okay! there has been")
        print("an emergency with another patient and your")
        print("session will unfortunately be cancelled this")
        print("week. my apologies and sorry for any")
        print("inconvenience.")
        print("on another note: i remember you mentioned")
        print("your journals last session. would you mind")
        print("bringing them to our session next week?")
        print("you don't have to, of course, if you feel")
        print("uncomfortable showing it to others, that")
        print("would be perfectly fine. let me know!")
        print("thanks. see you soon.")
        space()
        print("(Huh....Therapy....)")
        explore()
    elif choice == "C":
        print("You open the closet.")
        print("There is not much amiss...")
        print("Clothes hung, blankets folded... and a journal!")
        yn = input("Look through it? Y or N:")
        if yn == "Y":
            print("There isn't much special. Hopes and dreams of a musician searching, begging for fame.")
            print("This is normal.")
            print("...")
            time.sleep(2.5)
            print("But why are some of the pages ripped out?")
        explore()
    elif choice == "B":
        global bookcase_times
        if bookcase_times == 0:
            print("You walk over to the bookshelf.")
            print("There isn't much. A couple of romance novels, a scattered collection of theory textbooks, some yearbooks.")
            print("There is a photo of a woman - face scratched out with permanent marker - sitting on the shelf.")
            print("Behind her are the aurora borealis.")
            print("Wait... there's an envelope here.")
            print("Why are there... more photos of Matthew Zhang?")
            time.sleep(2.5)
            print("...")
            print("Is that... In this photo... Is he sitting in THIS room?")
            bookcase_times += 1
        else:
            print("The yearbook... Sophomore year...")
            print("There is a key stuck in one of the pages.")
            print("You flip to the key - page 127, a face is crossed out and another is cut out.")
            global key
            key = input("Do you take the key? Y or N:")
            if key == "Y":
                print("Hm... maybe try the door... or that locked drawer...")
            else:
                print("Are you trying to make everything difficult for yourself or what?")
                print("Take the key next time.")
        explore()
    elif choice == "R":
        if key == "N":
            print("The drawer is locked.")
            print("Let's keep searching...")
            explore()
        else:
            print("There are pieces of ripped, folded lined paper and a orange bottle of pills.")
            print("You look through the pages.")
            print("...")
            time.sleep(2.5)
            print("...")
            time.sleep(2.5)
            print("There is a prescription. Issued November 23, 20XX. Two pills a day. Sleeping pills. 30 pills in the bottle.")
            print("The phone tells you the date is November 24, 20XX.")
            print("...")
            time.sleep(2.5)
            print("Why are there only two pills left?")
        return
explore()

space()
print("F#M3")
print("How far are you willing to go for fame?")
time.sleep(2.5)
space()
print("end.")