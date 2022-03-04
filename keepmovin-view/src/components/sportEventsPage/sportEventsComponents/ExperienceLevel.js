﻿import React, {useRef, useState} from 'react';
import CheckIcon from '@mui/icons-material/Check';
import {useDispatch, useSelector} from "react-redux";
import {changeExperience} from "../../../features/Experience";

const ExperienceLevel = (props) => {

    const ref = useRef(null);
    
    const markedLevels = useSelector((state) => state.experience.value)

    const dispatch = useDispatch();

    function MarkAsChecked() {
        
        let experienceLevel = ref.current
        
        experienceLevel.classList.toggle("check-icon__toggle")

        if (experienceLevel.classList.contains("check-icon__toggle")) {
                dispatch(changeExperience([...markedLevels, props.levelSelected]))
        }
        
        else {
            dispatch(changeExperience(markedLevels.filter((markLevel) =>
                markLevel.experienceLevelId !== props.levelSelected.experienceLevelId)))
        }
    }
    
    return (
        <div onClick={MarkAsChecked} className="experience-item level">
            {props.level}<CheckIcon ref={ref} className="check-icon check-icon__toggle"/>
        </div>
    )
}
export default ExperienceLevel;