class parachute 
{
  Compare compare = new Compare();
 //the images for the jumper.
 public string[] img ={
   @"
     ___
    /___\
    \   /
     \ /
      0
     /|\
     / \
   ^^^^^^^",
   @"   
    /___\
    \   /
     \ /
      0
     /|\
     / \
   ^^^^^^^",
    @"   
       
    \   /
     \ /
      0
     /|\
     / \
   ^^^^^^^",
    @"    
       
     \ /
      0
     /|\
     / \
   ^^^^^^^",
    @"   
       
      x
     /|\
     / \
   ^^^^^^^"};

  public string paraPop() {
    int stage = compare.wrongAnswer();
    string currentImage;
    if (stage == 0) {
      currentImage = img[stage];
    } 
    else if (stage == 1) {
      currentImage = img[stage];
    }
    else if (stage == 2) {
      currentImage = img[stage];
    }
    else if (stage == 3) {
      currentImage = img[stage];
    }
    else {
      currentImage = img[stage];
    }
    return currentImage;
   }
}
///