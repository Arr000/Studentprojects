/*
   * A class that maintains information on a book.
   * This might form part of a larger application such
   * as a library system, for instance.
   *
   * @author (Insert your name here.)
   * @version (Insert today’s date here.)
   */
  public class Book
  {
      // The fields.
      private String author;
      private String title;
      private int pages;
      private String refNumber;
      private int borrowed;
      private boolean courseText;
      /**
       * Set the author and title fields when this object
       * is constructed.
       */
      public Book(String bookAuthor, String bookTitle, int bookPages, boolean immutable)
      {
          author = bookAuthor;
          title = bookTitle;
          pages = bookPages;
          refNumber = "";
          courseText = immutable;
         
      }
      // Add the methods here...
      
      public void printAuthor()
      {
          System.out.println(author);
      }
      public void printbookTitle()
      {
          System.out.println(title);
      }
      public int getpages()
      {
          return pages;
      }
      
      
      public void getbookInformation()
      {
         System.out.println("Author " + author + " Booktitle " + title + " Pages " + pages);
         
         if (refNumber.length() > 0)
         {
             System.out.println("Refnumber: " + refNumber);
        
         }
         else 
         {
             System.out.println("ZZZZ");
            
         }
            System.out.println("\"" + title + "\" has been borrowed " + borrowed + " times");

       
      }
      
      public boolean iscourseText()
      
     {
         return courseText;
     }
      
      public int borrowed()
      {
          return borrowed;
      }
      
      public void borrow()
      {
          borrowed = borrowed +1;
      }
      
      public String getRefNumber()
      {
        return refNumber;
      }
    
      public void setRefNumber(String ref)
      { 
        if (ref.length() >= 3)
       {
        refNumber = ref;
      }
      else 
      {
       System.out.println ("Your ref has to be at least 3 charachters"); 
      }
    }
 }
 