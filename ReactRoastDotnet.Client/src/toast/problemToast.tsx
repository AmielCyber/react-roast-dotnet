import toast, {ErrorIcon} from "react-hot-toast";
// My Imports.
import type ProblemDetails from "../models/ProblemDetails.ts";
import ProblemDetailsToast from "./ProblemDetailsToast.tsx";

function problemToast(problemDetails: ProblemDetails) {
    toast((toast) => <ProblemDetailsToast toast={toast} problemDetails={problemDetails}/>, {
        icon: <ErrorIcon/>,
    });
}

export default problemToast;