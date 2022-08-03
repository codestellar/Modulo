import React from 'react'
import "../../../styles/AdminPanelHome.scss";
import NavbarAP from '../../../components/AdminPanelComponents/NavbarAP';
import SidebarAP from '../../../components/AdminPanelComponents/SidebarAP';
import EditLecHall from './EditDegree';

const APEditDegreePage = () => {
  return (
    <>
        <NavbarAP />
        <div className="sidebarAP-container">
            <SidebarAP />
            <EditLecHall  />
        </div>
    </>
  )
}

export default APEditDegreePage;