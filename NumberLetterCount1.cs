using System;
class prj17
{
 public static void Main(String [] args)
 {
        String []a=new String []{"one","two","three","four","five","six","seven","eight","nine"};
	    String []b=new String []{"eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"};
        String []c=new String []{"ten","twenty","thirty","forty","fifty","sixty","seventy","eighty","ninety"};
		String []d=new String []{"onehundred","twohundred","threehundred","fourhundred","fivehundred","sixhundred","sevenhundred","eighthundred","ninehundred"};
        String e="";
        String f="";
		String g="";
		for(int i=0;i<10;i++)
		{
		 if(i>=1)
		 {
		  f=d[i-1];
		 }
		 for(int j=0;j<10;j++)
		  {
		  if(j>=1)
		  {
		  e=c[j-1];
		  }
		    for(int k=0;k<10;k++)
			{
			    if(i==0&&j==0&&k<9)
                  {
				   Console.WriteLine(a[k]);
				   g+=a[k];
                  }				 
                if(i==0&&j==1&&k<9)
                  {
				    Console.WriteLine(b[k]);
					g+=b[k];
				  }
                if(i==0&&j>1&&k<9)
                  {
				   Console.WriteLine(e+a[k]);
				   g+=e+a[k];
				  }
                if(i==0&&j<9&&k==9)
                {
				 Console.WriteLine(c[j]);
				 g+=c[j];
				}
                 if(i>=1&&j>1&&k<9)
                  {
				  Console.WriteLine(f+"and"+e+a[k]);
				  g+=f+"and"+e+a[k];
				  }
				  if(i>=1&&j>1&&k==9&&j<9)
				  {
				  Console.WriteLine(f+"and"+c[j]);
				  g+=f+"and"+c[j];
				  }
                 if(i==0&&j==9&&k==9)
                  {
				  Console.WriteLine(d[i]);
				  g+=d[i];
				  }
                 if(i==9&&j==9&&k==9)
                   {
				   Console.WriteLine("onethousand");
				   g+="onethousand";
				   }
                if(i>=1&&j==1&&k<9)
                 {
				  Console.WriteLine(f+"and"+b[k]);
				  g+=f+"and"+b[k];
				 }
                if(i>=1&&j==0&&k<9)
                {
				Console.WriteLine(f+"and"+a[k]);
				g+=f+"and"+a[k];
				}
                if(i>=1&&j==0&&k==9)
                {
				Console.WriteLine(f+"and"+c[j]);
				g+=f+"and"+c[j];
				}
                if(i>=1&&j==1&&k==9)
               {
			   Console.WriteLine(f+"and"+c[j]);
			   g+=f+"and"+c[j];
			   }
              if(i>=1&&j==9&&k==9&&i<9)
               {
			    Console.WriteLine(d[i]);
				g+=d[i];
			   }			  
			}
		  }
		}
		Console.WriteLine("the length is:"+g.Length);
 }
}