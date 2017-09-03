import clr
clr.AddReference("System.Drawing")
from System.Drawing import *
import math

def Main (image, color):

    if "RED" in color:
        for x in range(image.Width):
            for y in range(image.Height):
                c = image.GetPixel(x, y)
                image.SetPixel(x, y, Color.FromArgb(0, c.G, c.B))
    elif "BLUE" in color:
        for x in range(image.Width):
            for y in range(image.Height):
                c = image.GetPixel(x, y)
                image.SetPixel(x, y, Color.FromArgb(c.R, c.G, 0))

    elif "GREEN" in color:
        for x in range(image.Width):
            for y in range(image.Height):
                c = image.GetPixel(x, y)
                image.SetPixel(x, y, Color.FromArgb(c.R, 0, c.B))
    return image