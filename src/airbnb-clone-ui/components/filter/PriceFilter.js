import { Popover } from '@headlessui/react'

function PriceFilter() {
    return (
    <Popover className="relative border-0">
        <Popover.Button className="focus:outline-none"><p className="filter-button">Price</p></Popover.Button>
        <Popover.Panel className="absolute z-10 w-screen max-w-[300px] px-4 mt-3 transform -translate-x-1/2 left-1/2 sm:px-0">
        <div className="overflow-hidden rounded-lg shadow-lg ring-1 ring-black ring-opacity-5">
            <div className="bg-white">
              <h4 className="px-5 pt-3">Daily price</h4>
              <div className="flex justify-between items-center py-5">
                <input type="text" placeholder="$100"
                  className="form-input
                    ml-5
                    block
                    w-[100px]
                    rounded-md
                    border-gray-300
                    shadow-sm
                    focus:border-indigo-300 
                    focus:ring 
                    focus:ring-indigo-200 
                    focus:ring-opacity-50"
                />
                <p>-</p>
                <input type="text"  placeholder="$50000"
                    className="form-input
                      mr-5
                      block
                      w-[100px]
                      rounded-md
                      border-gray-300
                      shadow-sm
                      focus:border-indigo-300 
                      focus:ring 
                      focus:ring-indigo-200 
                      focus:ring-opacity-50"
                    />
              </div>
              <div className="border-b"/>
              <div className="px-5 p-2 flex flex-row-reverse">
                <button className="save-button">Save</button>
              </div>
            </div>
        </div>    
        </Popover.Panel>
            
       
      </Popover>
      )
}

export default PriceFilter
