import React, {FC, ChangeEvent, useState} from 'react';
import NoticeCard from "../components/Noticeboard/NoticeCard";
import NoticeInput from '../components/Noticeboard/NoticeInput';
import Dropdown from '../components/Noticeboard/Dropdown';
import "../styles/NoticeBoard.scss";



function NoticeBoard(){

  return  (

     <div className="NoticeBoard">
     
            <div className ="NoticeBoard-title"> 
                        <h1>Notice Board</h1>
                        
            </div>

            <br></br>

            <div className="Dropdown">
               <p>Order by:</p>
                  <Dropdown/>
               
            </div>

            <br></br>
   
         <>
            <div>
            <NoticeInput />
            </div>
        </>
     </div>
   
        
);
}

     

export default NoticeBoard;
   