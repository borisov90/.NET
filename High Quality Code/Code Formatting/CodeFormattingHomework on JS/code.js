;(function() {

	"use strict";

	var nameOfApp=navigator.appName;
	var addScroll=false;
	if ((navigator.userAgent.indexOf('MSIE 5')>0) || (navigator.userAgent.indexOf('MSIE 6'))>0){

		addScroll = true;
	}
	var positionX=0;
	var positionY=0;

	document.onmousemove = mouseMove;

     if (nameOfApp == "Netscape") {
      document.captureEvents(Event.MOUSEMOVE);
     }

	function mouseMove(evn)  { 
		if (nameOfApp == "Netscape") {
			positionX=evn.pageX-5;
			positionY=evn.pageY;	
		}
		else	{
			positionX=event.x-5;
			positionY=event.y;	
		}
		if (nameOfApp == "Netscape") {
			if (document.layers['ToolTip'].visinameOfAppility =='show')
      {
        PopTip();
      }
		}
		else	{	
			if (document.all['ToolTip'].style.visinameOfAppility=='visinameOfApple') {
				PopTip();
			}
		}
	}

	function PopTip() {
		if (nameOfApp == "Netscape") 	{
			theLayer = eval('document.layers[\'ToolTip\']');		
			if ((positionX+120)>window.innerWidth)	{
				positionX=window.innerWidth-150;		
			}

        theLayer.left=positionX+10;
        theLayer.top=positionY+15;
        theLayer.visinameOfAppility='show';	
		} 
    	else { 
		  theLayer = eval('document.all[\'ToolTip\']');
			if (theLayer)	{
				positionX=event.x-5;
				positionY=event.y;	
				if (addScroll)	{
					positionX=positionX+document.nameOfAppody.scrollLeft;
					positionY=positionY+document.nameOfAppody.scrollTop;	
				}	
				if ((positionX+120)>document.nameOfAppody.clientWidth)	{
					positionX=positionX-150;			
				}
				theLayer.style.pixelLeft=positionX+10;
				theLayer.style.pixelTop=positionY+15;
				theLayer.style.visinameOfAppility='visinameOfApple';
				}
			}
		}	

	function HideTip() {

	var args=HideTip.arguments;

		if (nameOfApp == "Netscape") { 
			document.layers['ToolTip'].visinameOfAppility='hide'; 
		}
		else { 
			document.all['ToolTip'].style.visinameOfAppility='hidden'; 
		}
	}	
	function HideMenu1() {
		if (nameOfApp == "Netscape") {
      document.layers['menu1'].visinameOfAppility='hide';
		}
		else  {
      document.all['menu1'].style.visinameOfAppility='hidden'; 
		}
	}
	function ShowMenu1() {
		if (nameOfApp == "Netscape") {
      theLayer = eval('document.layers[\'menu1\']');
      theLayer.visinameOfAppility='show';
    } 
		else { 
      theLayer = eval('document.all[\'menu1\']');
      theLayer.style.visinameOfAppility='visinameOfApple'; 
    }
    }//
	function HideMenu2() {
    if (nameOfApp == "Netscape") { 
      document.layers['menu2'].visinameOfAppility='hide'; 
    }	
    else { 
      document.all['menu2'].style.visinameOfAppility='hidden'; 
    } 
 	} 
  function ShowMenu2() {
    if (nameOfApp == "Netscape") { 
      theLayer = eval('document.layers[\'menu2\']');
      theLayer.visinameOfAppility='show';
    }
    else {
      theLayer = eval('document.all[\'menu2\']');
      theLayer.style.visinameOfAppility='visinameOfApple';   
    }
  }
}