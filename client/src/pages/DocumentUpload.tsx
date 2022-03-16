import { type } from "os";
import React, { useState } from "react";
import "../styles/DocumentUploader.scss";
import FileSelector from "../components/DocumentManager/Document-uplaod/FileSelector";
import RecentUpload from "../components/DocumentManager/Document-uplaod/RecentUpload";
import DocumentUploadTitle from "../components/DocumentManager/Document-uplaod/DocumentUploadTitle";
import Navbar2 from "../components/Navbar2";

function DocumentUpload() {
  const [documents, setDocuments] = useState([
    {
      name: "Hypothesis_Testing.pdf",
      size: "15MB",
      type: "pdf",
      date: "01/19/2021",
      description: "wgduegfierhgolrgj",
    },
    {
      name: "Boolean_Algebra.pdf",
      size: "9MB",
      type: "pdf",
      date: "10/11/2021",
      description: "wgduegfierhgobhjg uhihrg ghirhgorh",
    },
    {
      name: "ProjectProposalTemplate.ppt",
      size: "10MB",
      type: "ppt",
      date: "02/05/2022",
      description: "wgduegfierhgolrgj bjug gugiug huiggiuh gugugu huuihihljl",
    },
  ]);

  return (
    <>
      <div>
        <Navbar2 />
      </div>
      <div className="DocumentUploader">
        <DocumentUploadTitle />
        <FileSelector docs={documents} setDocs={setDocuments} />
        <br />
        <RecentUpload docs={documents} setDocs={setDocuments} />
      </div>
    </>
  );
}

export default DocumentUpload;
